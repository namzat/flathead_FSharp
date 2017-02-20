// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open ShiftOps
open Type
open Utility

let word = 0xBEEF

let fetch_bits_original high length word =
    let mask = lnot (-1 lsl length) in
        (word lsr (high - length + 1)) land mask

[<EntryPoint>]
let main argv = 
    printfn "\n\n%0x\n\n" ((word lsr 12) land (lnot(-1 lsl 15)));
    printfn "\n\n%0x\n\n" (fetch_bits_original 15 4 word);
    printfn "\n\n%0x\n\n" (fetch_bits bit15 size4 word)
    0 // return an integer exit code
