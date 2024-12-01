# Day 1

## Part 1
Pair up the smallest number in the left list with the smallest number in the right list, then the second-smallest left 
number with the second-smallest right number, and so on.
Within each pair, figure out how far apart the two numbers are; you'll need to add up all of those distances.

### For Example:
L list: 2, 4, 2, 1, 3, 3
R list: 4, 3, 5, 3, 9, 3

If you pair up a 3 from the left list with a 7 from the right list, the distance apart is 4; if you pair up
a 9 with a 3, the distance apart is 6.

To find the total distance between the left list and the right list, add up the distances between all the pairs you found.
In the example above, this is 2 + 1 + 0 + 1 + 2 + 5, a total distance of 11!

## Part 2
--- Part Two ---
Your analysis only confirmed what everyone feared: the two lists of location IDs are indeed very different.

Or are they?

The Historians can't agree on which group made the mistakes or how to read most of the Chief's handwriting, but in the commotion you notice an interesting detail: a lot of location IDs appear in both lists! Maybe the other numbers aren't location IDs at all but rather misinterpreted handwriting.

This time, you'll need to figure out exactly how often each number from the left list appears in the right list. Calculate a total similarity score by adding up each number in the left list after multiplying it by the number of times that number appears in the right list.