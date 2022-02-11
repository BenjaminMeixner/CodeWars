namespace Kata

module PerfectSquare =

    let private Check i n = (i * i) = n

    let rec private isPerfectSquare i n =
        if i = n && i > 1 then
            false
        else 
            Check i n || isPerfectSquare (i + 1) n
    
    let IsPerfectSquare (n : int) =
        isPerfectSquare 0 n
