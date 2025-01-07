let mutable x = 1
let mutable y = 2
let z = ref (x + y)
printf "%d\n" !z
x <- 3
z := x + y
printf "%d\n" !z