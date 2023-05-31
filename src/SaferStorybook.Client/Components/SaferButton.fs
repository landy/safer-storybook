module SaferStorybook.Client.Components.SaferButton

open Feliz

type SaferButtonProps = {
    Label: string
}

[<ReactComponent>]
let SaferButton (props: SaferButtonProps) =
    Html.input [
        prop.type'.button
        prop.value props.Label
    ]
