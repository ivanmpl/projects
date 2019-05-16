
        // browser objects for use in game
        const guesses = document.querySelector('.guesses');
        const lastResult = document.querySelector('.lastResult');
        const lowOrHi = document.querySelector('.lowOrHi');
        const guessSubmit = document.querySelector('.guessSubmit');
        const guessField = document.querySelector('.guessField');


        // Generate random number; Floor function to round integer
        function getRandomInt(max) {
            return Math.floor(Math.random() * Math.floor(max) + 1);
        }

        // Get user entered guess
        function getGuess() {
            return Number(guessField.value);
        }

        // Reset Game counters
        function resetGame() {

        }

        function checkGuess() {

            // User submitted guess integer
            let userGuess = getGuess();

            // Generate random number 1-100
            let randomNumber = getRandomInt(100);

            let guessCount = 1;
            let resetButton;

            // Determine outcome of guess
            if (userGuess === randomNumber) {
                lastResult.textContent = 'Correct guess';
                lastResult.style.backgroundColor = 'green';
                lowOrHi.textContent = '';
                resetGame();
            }
            else if (guessCount === 10) {
                lastResult.textContent = 'Incorrect guess and exceeded 10 guess limit';
                resetGame();
            }
            else {
                lastResult.textContent = 'Incorrect guess';
                lastResult.style.backgroundColor = 'red';
                if (userGuess > randomNumber) {
                    lowOrHi.textContent = 'last guess was too high';
                }
                else if (userGuess < randomNumber) {
                    lowOrHi.textContent = 'last guess was too low';
                }
            }

            guessCount++;
            guessField.value = '';
            guessField.focus();
        }

        guessSubmit.addEventListener('click', checkGuess);
