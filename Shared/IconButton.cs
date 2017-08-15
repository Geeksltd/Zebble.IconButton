namespace Zebble
{
    using System;
    using System.Threading.Tasks;

    public class IconButton : Canvas, ITextControl
    {
        IconLocation iconLocation = IconLocation.Left;
        public readonly TextView TextView = new TextView { Id = "TextView" };
        public readonly ImageView Icon = new ImageView { Id = "Icon" };

        public IconButton()
        {
            AutoFlash = Button.DefaultAutoFlash;
        }

        public override async Task OnInitializing()
        {
            await base.OnInitializing();

            await Add(TextView);
            await AddIcon(Icon.Path);

            SetIconLocation();
        }

        public Task AddIcon(string iconPath) => Add(Icon.Path(iconPath));

        public string IconPath { get => Icon.Path; set => Icon.Path = value; }

        void SetIconLocation()
        {
            if (IconLocation == IconLocation.Left)
                Icon.X.BindTo(Icon.Margin.Left, Padding.Left, (x, y) => x + y);
            else
                Icon.X.BindTo(Width, Icon.Width, Icon.Margin.Right, Padding.Right, (total, icon, imr, pr) => total - icon - imr - pr);
        }

        protected override string GetStringSpecifier() => TextView.Text.Or(Icon.Path);

        public string Text { get => TextView.Text; set => TextView.Text = value; }

        public IconLocation IconLocation
        {
            get => iconLocation;
            set
            {
                if (value == iconLocation) return;
                iconLocation = value;

                if (AllChildren.Contains(Icon))
                {
                    // Already added: change the index.
                    AllChildren.Remove(Icon);
                    if (value == IconLocation.Left) AllChildren.Insert(0, Icon);
                    else AllChildren.Add(Icon);

                    SetIconLocation();
                }
            }
        }
    }
}