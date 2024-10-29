const votesData = {
    "What is your favorite color?": {
        "Red": 5,
        "Blue": 10,
        "Green": 3
    }
};

document.getElementById('statsForm').addEventListener('submit', function (event) {
    event.preventDefault();
    const question = document.getElementById('question').value;

    if (votesData[question]) {
        displayStatistics(question, votesData[question]);
    } else {
        alert('No statistics available for this question.');
    }
});

function displayStatistics(question, stats) {
    document.getElementById('statsQuestion').innerText = question;
    const statsList = document.getElementById('statsList');
    statsList.innerHTML = ''; // Clear previous stats

    for (const answer in stats) {
        const listItem = document.createElement('li');
        listItem.innerText = `${answer}: ${stats[answer]} votes`;
        statsList.appendChild(listItem);
    }

    document.getElementById('statsSection').style.display = 'block';
}
