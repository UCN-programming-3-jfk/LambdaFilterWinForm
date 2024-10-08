using System.Drawing;

namespace LambdaFilterWinForm
{
    public class Plant
    {
        public string Name { get; set; }
        public Color Color{ get; set; }
        public bool ToleratesShade { get; set; }
        public int HeightInCm { get; set; }

        public override string ToString()
        {
            return $"{Color} {Name}, {HeightInCm}cm ({(ToleratesShade ? "shade ok" : "no shade")})";
        }
    }
}