module SaferStorybook.Client.Components.SaferButton_Stories

open Fable.Core.JsInterop

open SaferStorybook.Client.Components.SaferButton

exportDefault
    {|
        ``component`` = SaferButton
    |}

let Simple = fun _ -> SaferButton { Label = "Example button label" }

let WithArgs =
    {|
        args = { Label = "Example button label" }
    |}