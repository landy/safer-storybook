module SaferStorybook.Client.Components.SaferButton

open Feliz

type SaferButtonProps = {
    Label: string
}

[<ReactComponent>]
let SaferButton (props: SaferButtonProps) =
    Html.input [
        prop.type'.button
        prop.className "btn btn-primary"
        prop.value props.Label
    ]