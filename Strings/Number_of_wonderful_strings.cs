public class Solution
{
    public long WonderfulSubstrings(string word)
    {
        long ans = 0;                 // total number of wonderful substrings found so far
        int mask = 0;                 // 10-bit parity mask for letters a..j (bit=1 => odd count, bit=0 => even)

        long[] freq = new long[1 << 10]; // frequency of each 10-bit mask seen as a *prefix*; size = 2^10 = 1024
        freq[0] = 1;                   // empty prefix: before reading any chars, mask=0 has occurred once

        foreach (char c in word)
        {     // scan the string left to right, building prefix parity
            mask ^= 1 << (c - 'a');    // toggle this letter’s bit (odd <-> even) in the running parity mask

            // Case A: substrings ending here with *all-even* counts
            // If a previous prefix had the *same* mask, XOR = 0 => the substring between them has all-even counts.
            ans += freq[mask];

            // Case B: substrings ending here with *exactly one* odd count
            // If a previous prefix differs by exactly one bit, XOR has exactly one bit set => one odd letter.
            for (int b = 0; b < 10; b++)
            {
                ans += freq[mask ^ (1 << b)];
            }

            // Record that we've now seen this prefix mask one more time
            freq[mask]++;
        }

        return ans;                     // total wonderful substrings
    }
}
