using System.IO;

class CopyBinaryFile
{
    private const string PicturePath = "Dog.jpg";
    private const string CopyPath = "Dog Copy.jpg";
   
    public static void Main()
    {
        FileStream inputStream = new FileStream(PicturePath, FileMode.Open);
        FileStream outputStream = new FileStream(CopyPath, FileMode.Create);

        using (inputStream)
        {
            using (outputStream)
            {
                byte[] buffer = new byte[4096];

                while (true)
                {
                    int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    outputStream.Write(buffer, 0, readBytes);
                }
            }
        }
        System.Diagnostics.Process.Start("Dog Copy.jpg");
    }
}