open Robots


///Creating a board 4 x 7 for a game.
let board = Board (4, 7)
let frame = BoardFrame (4, 7)

board.AddElement (frame)
board.AddElement (HorizontalWall (1, 2, 1))
board.AddElement (VerticalWall (1, 2, 1))
board.AddElement (HorizontalWall (0, 3, 2))
board.AddElement (Robot (0, 0, "bb"))
board.AddElement (Robot (1, 2, "aa"))
board.AddElement (Robot (3, 6, "cc"))
board.AddElement (Goal (2, 5))
board.AddElement (Trap (1, 0))
board.AddElement (Helper (frame))

let game = Game (board)

game.Play() |> ignore