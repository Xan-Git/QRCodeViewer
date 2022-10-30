namespace QRCodeViewer
{
    public static class Extensions
    {
        public static byte[] ColorToRGB(this Color color)
        {
            switch (color)
            {
                case Color.Red:
                     return new byte[3] { 240, 10, 10 };

                case Color.Green:
                    return new byte[3] { 10, 240, 10 };

                case Color.Blue:
                    return new byte[3] { 10, 10, 240 };

                case Color.White:
                    return new byte[3] { 255, 255, 255 };

                case Color.Black:
                    return new byte[3] { 0, 0, 0 };

                default:
                    return new byte[3] { 128, 128, 128 };
            }
        }
    }
}
