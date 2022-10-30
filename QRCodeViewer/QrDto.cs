namespace QRCodeViewer
{
    public class QrDto
    {
        public string Url { get; set; } = "";

        // Side length of square in pixels
        public int Size { get; set; }

        public Color LightColor { get; set; } = Color.White;

        public Color DarkColor { get; set; } = Color.Black;
    }

    public enum Color
    {
        Red,
        Blue,
        Green,
        White,
        Black
    }

    
}
