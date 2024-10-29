document.getElementById('qrForm').addEventListener('submit', function (event) {
    event.preventDefault();
    const qrData = document.getElementById('qrInput').value;

    try {
        const voteData = JSON.parse(qrData);
        document.getElementById('questionText').innerText = voteData.question;

        const answersContainer = document.getElementById('answersContainer');
        answersContainer.innerHTML = ''; // Clear previous answers

        voteData.answers.forEach(answer => {
            const label = document.createElement('label');
            const input = document.createElement('input');
            input.type = 'radio';
            input.name = 'vote';
            input.value = answer;
            label.appendChild(input);
            label.appendChild(document.createTextNode(answer));
            answersContainer.appendChild(label);
            answersContainer.appendChild(document.createElement('br'));
        });

        document.getElementById('voteSection').style.display = 'block';
    } catch (error) {
        alert('Invalid QR code data. Please try again.');
    }
});

document.getElementById('voteForm').addEventListener('submit', function (event) {
    event.preventDefault();
    const selectedVote = document.querySelector('input[name="vote"]:checked');
    if (selectedVote) {
        alert(`You voted for: ${selectedVote.value}`);
        // Here you would send the vote to your server
    } else {
        alert('Please select an option before voting.');
    }
});
