// isValid reports whether the parentheses/brackets/braces in s are balanced.
func isValid(s string) bool {
	stack := make([]rune, 0, len(s))

	for _, r := range s {
		switch r {
		case '(', '[', '{':
			// Push the matching closing rune onto the stack
			switch r {
			case '(':
				stack = append(stack, ')')
			case '[':
				stack = append(stack, ']')
			case '{':
				stack = append(stack, '}')
			}
		default:
			if len(stack) == 0 || stack[len(stack)-1] != r {
				return false
			}
			stack = stack[:len(stack)-1] // Pop
		}
	}

	return len(stack) == 0
}
