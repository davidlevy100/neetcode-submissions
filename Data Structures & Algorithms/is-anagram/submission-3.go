func isAnagram(s, t string) bool {
    if len(s) != len(t) {
        return false
    }

    seen := make(map[rune]int)

    for _, r := range s {
        seen[r]++
    }

    for _, r := range t {
        seen[r]--
    }

    for _, v := range seen {
        if v != 0 {
            return false
        }
    }
    return true
}
