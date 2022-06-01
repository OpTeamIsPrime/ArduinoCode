using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing;
using System.Drawing.Imaging;

namespace Module.AForge.Extensions
{
    public static class BitmapExtensions
    {
        public static Bitmap EuclideanFilter(this Bitmap source, Color color, short radius = 100)
        {
            var image = (Bitmap)source.Clone();//https://csharpdoc.hotexamples.com/class/AForge.Imaging.Filters/EuclideanColorFiltering
            var filter =
                new EuclideanColorFiltering
                {
                    CenterColor = new RGB(Color.FromArgb(color.R, color.G, color.B)),//ARGB = alpha red green blue
                    Radius = radius
                };

            filter.ApplyInPlace(image);
            return image;
        }
        public static Bitmap FindObjectsOnFiltered(this Bitmap source, Color penColor, int minObjectWidth = 5, int minObjectHeight = 5, bool multiple = false)
        {
            var image = (Bitmap)source.Clone();//recupere l'image a analyser
            BlobCounter blobCounter = new BlobCounter//permet de compter des objet dans une image qui est séparé par un font noir voir :
                                                     //https://csharp.hotexamples.com/fr/examples/AForge.Imaging/BlobCounter/-/php-blobcounter-class-examples.html
            {
                MinWidth = minObjectWidth,
                MinHeight = minObjectHeight,
                FilterBlobs = true,
                ObjectsOrder = ObjectsOrder.Size
            };

            var objectsData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
            var grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            image.UnlockBits(objectsData);

            blobCounter.ProcessImage(image);
            var rects = blobCounter.GetObjectsRectangles();

            if (rects.Length <= 0) return source;

            Graphics g = Graphics.FromImage(source);//cree un éléments graphique sur notre retour vidéo 
            for (int i = 0; rects.Length > i; i++)
            {
                Rectangle objectRect = rects[i];
                using (Pen pen = new Pen(Color.FromArgb(penColor.R, penColor.G, penColor.B), 2))//dessine un rectangle sur l'image pour delimiter l'objet
                {
                    g.DrawRectangle(pen, objectRect);

                    if (multiple)
                        g.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.Red, objectRect);
                }

                if (multiple) continue;
                g.Dispose();
                return source;
            }

            g.Dispose();
            return source;
        }
        public static Bitmap FindObjectsOnOrjinal(this Bitmap source, Color penColor, Color filterColor, short filterRadius = 100, int minObjectWidth = 5, int minObjectHeight = 5, bool multiple = false)
        {
            var fake = (Bitmap)source.Clone();
            var image = fake.EuclideanFilter(filterColor, filterRadius);
            var orj = (Bitmap)source.Clone();

            BlobCounter blobCounter = new BlobCounter
            {
                MinWidth = minObjectWidth,
                MinHeight = minObjectHeight,
                FilterBlobs = true,
                ObjectsOrder = ObjectsOrder.Size
            };

            var objectsData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
            var grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            image.UnlockBits(objectsData);

            blobCounter.ProcessImage(image);
            var rects = blobCounter.GetObjectsRectangles();

            if (rects.Length <= 0) return orj;

            Graphics g = Graphics.FromImage(orj);
            for (int i = 0; rects.Length > i; i++)
            {
                Rectangle objectRect = rects[i];
                using (Pen pen = new Pen(Color.FromArgb(penColor.R, penColor.G, penColor.B), 2))
                {
                    g.DrawRectangle(pen, objectRect);

                    if (multiple)
                        g.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.Red, objectRect);
                }

                if (multiple) continue;
                g.Dispose();
                return orj;
            }

            g.Dispose();
            return orj;

        }
    }
}
