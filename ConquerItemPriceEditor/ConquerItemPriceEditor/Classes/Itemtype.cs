using ConquerItemPriceEditor.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConquerItemPriceEditor
{
    public class Itemtype
    {
        private byte[] key;
        public Item[] Items;
        public string SourceFile;
        public string TargetFile;
        IniFile ItemMinIcon = new IniFile("Files/ani/ItemMinIcon.Ani");

        public void LoadItems()
        {
            string[] ItemsTxt = File.ReadAllLines(this.TargetFile);
            this.Items = new Item[ItemsTxt.Length];
            for (int i = 0; i < ItemsTxt.Length; i++)
            {
                this.Items[i] = new Item(ItemsTxt[i], true);
            }
        }

        public void SaveItems()
        {
            string[] lines = new string[this.Items.Length];
            for (int i = 0; i < this.Items.Length; i++)
            {
                this.Items[i].Export();
                lines[i] = this.Items[i].ToString();
            }
            File.WriteAllLines(this.TargetFile, lines);
            this.Encrypt();
        }

        public Itemtype(string SourceFile)
        {
            this.SourceFile = SourceFile;
            int seed;
            if (!int.TryParse("2537", NumberStyles.HexNumber, null, out seed))
            {
                return;
            }
            key = new byte[0x80];
            MSRandom r = new MSRandom(seed);
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = (byte)(r.Next() % 0x100);
            }
        }

        public string GetImagePath(Item item)
        {
            string fileDestination = "";
            try
            {
                fileDestination = "tmp_preview.png";
                string DDS = ItemMinIcon.GetValue("Item" + item.Get(Item.Atribute.ID), "Frame0");
                string fileSource = "Files/" + DDS;
                if (File.Exists(fileSource))
                {
                    ConvertImageDDSToPNG(fileSource, fileDestination);
                } else
                {
                    ConvertImageDDSToPNG("Files/data/ItemMinIcon/Default.dds", fileDestination);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                fileDestination = "tmp_preview.png";
                string DDS = ItemMinIcon.GetValue("ItemDefault", "Frame0");
                string fileSource = "Files/" + DDS;
                ConvertImageDDSToPNG(fileSource, fileDestination);
            }
            return fileDestination;
        }

        public void ConvertImageDDSToPNG(string src, string destination)
        {
            FreeImageAPI.FreeImage.Save(FreeImageAPI.FREE_IMAGE_FORMAT.FIF_PNG, FreeImageAPI.FreeImage.Load(FreeImageAPI.FREE_IMAGE_FORMAT.FIF_DDS, src, FreeImageAPI.FREE_IMAGE_LOAD_FLAGS.DEFAULT), destination, FreeImageAPI.FREE_IMAGE_SAVE_FLAGS.DEFAULT);
        }

        public void Decrypt()
        {
            byte[] b = File.ReadAllBytes(SourceFile);
            for (int i = 0; i < b.Length; i++)
            {
                int num = b[i] ^ key[i % 0x80];
                int bits = i % 8;
                b[i] = (byte)((num << (8 - bits)) + (num >> bits));
            }
            this.TargetFile = Path.GetDirectoryName(SourceFile) + "/" + Path.GetFileNameWithoutExtension(SourceFile) + ".txt";
            File.WriteAllBytes(this.TargetFile, b);
        }

        public void Encrypt()
        {
            byte[] b = File.ReadAllBytes(this.TargetFile);
            for (int i = 0; i < b.Length; i++)
            {
                int bits = i % 8;
                int num = (byte)((b[i] >> (8 - bits)) + (b[i] << bits));
                b[i] = (byte)(num ^ key[i % 0x80]);
            }
            File.WriteAllBytes(SourceFile, b);
        }

        public class MSRandom
        {
            public long Seed;
            public MSRandom(int seed)
            {
                Seed = seed;
            }
            public int Next()
            {
                return (int)(((Seed = Seed * 214013L + 2531011L) >> 16) & 0x7fff);
            }
        }
    }
}
