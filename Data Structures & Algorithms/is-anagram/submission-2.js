class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if (s.length !== t.length) {
            return false;
        }

        var letterCount = new Array(26).fill(0);

        for (var i = 0; i < s.length; i++) {
            letterCount[s.charCodeAt(i) - 97]++; // 'a' = 97 in ASCII
            letterCount[t.charCodeAt(i) - 97]--; // Decrease for 't' at the same time
        }

        return letterCount.every(count => count === 0);
    }
}
