using System.Numerics;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Shared.Localization;
using static Robust.Client.UserInterface.Controls.BoxContainer;

namespace Content.Client.Phantom;

public sealed class AcceptPhantomPowersWindow : DefaultWindow
{
    public readonly Button DenyButton;
    public readonly Button AcceptButton;

    public AcceptPhantomPowersWindow()
    {

        Title = Loc.GetString("accept-phantom-window-title");

        Contents.AddChild(new BoxContainer
        {
            Orientation = LayoutOrientation.Vertical,
            Children =
            {
                new BoxContainer
                {
                    Orientation = LayoutOrientation.Vertical,
                    Children =
                    {
                        (new Label()
                        {
                            Text = Loc.GetString("accept-phantom-window-prompt-text-part")
                        }),
                        new BoxContainer
                        {
                            Orientation = LayoutOrientation.Horizontal,
                            Align = AlignMode.Center,
                            Children =
                            {
                                (AcceptButton = new Button
                                {
                                    Text = Loc.GetString("accept-phantom-window-accept-button"),
                                }),

                                (new Control()
                                {
                                    MinSize = new Vector2(20, 0)
                                }),

                                (DenyButton = new Button
                                {
                                    Text = Loc.GetString("accept-phantom-window-deny-button"),
                                })
                            }
                        },
                    }
                },
            }
        });
    }
}