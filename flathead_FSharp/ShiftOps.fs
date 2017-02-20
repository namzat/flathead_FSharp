module ShiftOps
    let inline ( lsl ) (x: int32) (n:int) : int32 = x <<< n
    let inline ( lsr ) (x: int32) (n:int) : int32 = int32 (uint32 x >>> n)
    let inline ( asr ) (x: int32) (n:int) : int32 = x >>> n
    let inline ( land ) (x: int32) (n:int) : int32 = x &&& n
    let inline ( lor ) (x: int32) (n:int) : int32 = x ||| n
    let lnot (x: int32) : int32 = (~~~x)