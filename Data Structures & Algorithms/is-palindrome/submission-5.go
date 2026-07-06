// isPalindrome reports whether s is a palindrome, ignoring case and non-alphanumeric characters.
func isPalindrome(s string) bool {
	i, j := 0, len(s)-1

	for i < j {
		left := rune(s[i])
		if !unicode.IsLetter(left) && !unicode.IsDigit(left) {
			i++
			continue
		}

		right := rune(s[j])
		if !unicode.IsLetter(right) && !unicode.IsDigit(right) {
			j--
			continue
		}

		if unicode.ToLower(left) != unicode.ToLower(right) {
			return false
		}

		i++
		j--
	}
	return true
}