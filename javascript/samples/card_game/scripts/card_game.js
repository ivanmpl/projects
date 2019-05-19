// standard card deck
class Deck {
    // create and intialize deck types
    constructor() {
        // deck as array
        this.deck = [];
        // populate deck with cards
        this.resetDeck();

    }

    // Remove card from top of deck
    dealCard() {
        return this.deck.pop();
    }

    // TODO: fix randomize algorithm to Fisher-Yates shuffle
    shuffleDeck() {
        this.deck.sort(function () {
            return .5 - Math.random();
        });
    }

    // reset deck to original un-shuffled self
    resetDeck() {
        // reset instance array
        this.deck = [];
        // standard suite
        const suits = ['Hearts', 'Spades', 'Diamonds', 'Clubs'];
        // standard card values
        const values = ['Ace', 2, 3, 4, 5, 6, 7, 8, 9, 'Jack', 'Queen,', 'King'];
        // iterate through suits and values and save cross-products in deck 
        for (const suit_key in suits) {
            if (suits.hasOwnProperty(suit_key)) {

                for (const value_key in values) {
                    if (values.hasOwnProperty(value_key)) {

                        this.deck.push(values[value_key] + " of " + suits[suit_key]);
                    }
                }
            }
        }
    }
}


// browser objects for card game
const getCard = document.body.querySelector('#getCardBtn');
const shuffleDeck = document.body.querySelector('#shuffleDeckBtn');
const resetDeck = document.body.querySelector('#resetDeckBtn');

// browser function for card game
function dealPlayerCard() {
    document.getElementById('reset').innerText = null;
    document.getElementById('deck').innerText = null;
    document.getElementById('card').innerText = deck.dealCard();
}

function resetPlayerDeck() {
    deck.resetDeck();
    document.getElementById('reset').innerText = 'Deck Reset';
}

function shufflePlayerDeck() {
    deck.shuffleDeck();
    document.getElementById('deck').innerText = 'Deck Shuffled';
}

// create a instance of Deck type
var deck = new Deck();
// event listeners
getCard.addEventListener('click', dealPlayerCard);
shuffleDeck.addEventListener('click',shufflePlayerDeck);
resetDeck.addEventListener('click', resetPlayerDeck)


