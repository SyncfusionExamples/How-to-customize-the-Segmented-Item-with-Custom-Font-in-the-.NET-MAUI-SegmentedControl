using Syncfusion.Maui.Buttons;

namespace CustomFont
{
    public class CustomFontViewModel
    {
        private List<SfSegmentItem> segmentItems;
        public CustomFontViewModel()
        {
            segmentItems = new List<SfSegmentItem>()
            {
                new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue700", Size = 20, FontFamily = "SegmentIcon", Color = Colors.CadetBlue}, Text = "Day"},
                new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue701", Size = 20, FontFamily = "SegmentIcon",  Color = Colors.CadetBlue }, Text = "Week"},
                new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue701", Size = 20, FontFamily = "SegmentIcon",  Color = Colors.CadetBlue}, Text = "Month"},
                new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue703", Size = 20, FontFamily = "SegmentIcon",  Color = Colors.CadetBlue}, Text = "Year"},
            };
        }
        public List<SfSegmentItem> SegmentItems
        {
            get { return segmentItems; }
            set { segmentItems = value; }
        }
    }
}