// https://www.codewars.com/kata/554e4a2f232cdd87d9000038
// Complementary DNA

function DNAStrand(dna) {
    let res = ''
    for (let k in dna) {
        let v = dna[k]
        if (v == "A")
            res += "T"
        else if (v == "T")
            res += "A"

        if (v == "C")
            res += "G"
        else if (v == "G")
            res += "C"
    }
    return res
}
