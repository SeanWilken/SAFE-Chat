module Channel.View

open Fable.Helpers.React
open Props

open Chat.Types

let simpleButton txt action dispatch =
    div
        [ ClassName "column is-narrow" ]
        [ a
            [ ClassName "button"
              Style [Float "right"]
              OnClick (fun _ -> action |> dispatch) ]
            [ str txt ] ]

let chanMessages (messages: Message list) =
    div
      []
      [ for m in messages ->
          p [] [str m.Text]
      ]
let root (model: ChannelData) dispatch =
    div
      [ ClassName "content" ]
        [   h1 [] [ str model.Name ]
            simpleButton "Leave" (Leave model.Id) dispatch
            p [] [str model.Topic]
            p [] [str "TBD"]
            chanMessages model.Messages
        ]