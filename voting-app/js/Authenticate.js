document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault();
    // Mock authentication
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;

    // Simple validation (replace with actual authentication logic)
    if (username === 'user' && password === 'pass') {
        document.getElementById('voteSection').style.display = 'block';
    } else {
        alert('Invalid credentials. Please try again.');
    }
});

document.getElementById('voteForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const selectedVote = document.querySelector('input[name="vote"]:checked');
    if (selectedVote) {
        alert(`You voted for: ${selectedVote.value}`);
        // Here you would send the vote to your server
    } else {
        alert('Please select an option before voting.');
    }
});
