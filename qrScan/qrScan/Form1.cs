using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace qrScan
{
    public partial class fCode : Form
    {
        public fCode()
        {
            InitializeComponent();
        }

        private void bCreateCode_Click(object sender, EventArgs e)
        {
            string qrtext = textBox1.Text; //считываем текст с TextBox
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаем обьект класса
            Bitmap qrcode = encoder.Encode(qrtext, Encoding.UTF8); //кодируем слово полученное из TextBox'a. Создаем QR код
            pictureBox1.Image = qrcode as Image; // PictureBox выводит код как картинку
        }

        private void bSaveCode_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog save = new SaveFileDialog(); //save будет заправшивать у пользователя место, куда он захочет сохранить файл
                save.Filter = "PNG|*.png|JPEG|*.jpeg|GIF|*.gif|BMP|*.bmp"; //создает фильтр, который определяет в каком формате, мы захотим сохранить наше изображение. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расшрение_формата")
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку сохранить
                {
                    pictureBox1.Image.Save(save.FileName); // изображение из pictureBox'a сохраняется под именем, которое введет пользователь
                }
            }
        }

        private void bDownloadCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog(); //load будет запрашивать у пользователя место откудо он хочет загрузить картинку
            if(load.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "сохранить"
            {
                pictureBox1.ImageLocation = load.FileName; //в pictureBox'e открывается файл, который был запрошен по тому пути который указал пользователь
            }
        }

        private void bUnlockedCode_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder(); //создаем "раскодирование изображения"
            MessageBox.Show(decoder.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap), Encoding.UTF8)); //в messageBox'e программа запишет и выведет раскодированное изображение, которое предварительно будет переведено из pictureBox'a в класс Bitmap, чтобы мы смогли с этим изображением работать.
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
            }
        }
    }
}
