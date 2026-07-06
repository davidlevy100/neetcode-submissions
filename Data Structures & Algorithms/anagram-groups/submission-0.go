func groupAnagrams(strs []string) [][]string {
    // Map from letter-count array to list of anagrams
    anagrams := make(map[[26]int][]string)

    for _, s := range strs {
        hash := hashString(s)
        anagrams[hash] = append(anagrams[hash], s)
    }

    // Collect grouped anagrams
    var result [][]string
    for _, v := range anagrams {
        result = append(result, v)
    }

    return result
}

func hashString(s string) [26]int {
    var result [26]int
    for _, r := range s {
        result[r-'a']++
    }
    return result
}
