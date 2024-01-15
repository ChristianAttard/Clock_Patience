Project Title (Clock_Patience)
This is a game also known as the Clock Solitaire

Rules of the game:
Shuffle and deal the full deck of cards, face down, into 13 piles of 4 cards each, in the form of a clock.
One pile lies at each position from 1 o'clock to 12 o'clock and one at the centre (called 13 o'clock).
- Go to the centre (13 o’clock) pile.
  Turn over the top card.
  Record its face value k, an integer between 1 and 13 inclusive.

- Deposit this card face up beside the k o'clock pile.
  Turn over the top card from this pile.
  Record a new face value k.

- Repeat the last step as many times as possible,
  i.e. until the k o'clock pile is found to be empty.

The game of clock patience has been won if no card remains face down.

How the programme works:
- The sampleInput has been hardcoded in the main method, and must be replaced to further test the logic.
- A deck will be created using a 2D list, having a list of 13 piles with 4 cards in each pile
- The deck will be displayed in 13 piles with 4 cards each
- The game will start from index 12, being the middle point in the clock (King), and revealing the first card
- The first card will then move to the respective column face up, and another card will reveal from that current pile
- The game will continuously do this, until all cards have been revealed
- The final result would be the last card played and the turn it has been revealed
  
[clock_patience.pdf](https://github.com/ChristianAttard/Clock_Patience/files/13931933/clock_patience.pdf)
