$(document).ready(function () {
    $('#addQuestion').on('click', function () {
        const newQuestionBlock = `
            <div class="questionBlock">
                <label for="question">Question:</label>
                <input type="text" class="question" required>
                <label for="answers">Answers (comma-separated):</label>
                <input type="text" class="answers" required>
                <button type="button" class="removeQuestion">Remove Question</button>
            </div>`;
        $('#questionsContainer').append(newQuestionBlock);
    });

    $(document).on('click', '.removeQuestion', function () {
        $(this).closest('.questionBlock').remove();
    });

    $('#questionForm').on('submit', function (event) {
        event.preventDefault();

        const questions = [];
        $('.questionBlock').each(function () {
            const questionText = $(this).find('.question').val();
            const answersText = $(this).find('.answers').val();
            const answers = answersText.split(',');
            questions.push({ question: questionText, answers });
        });

        const voteDuration = parseInt($('#voteDuration').val());
        const voteData = JSON.stringify({ questions });
        $('#qrcode').empty();
        $('#qrcode').qrcode(voteData);

        startTimer(voteDuration);

        $('#qrCodeSection').show();
        $('#questionForm')[0].reset();
    });

    function startTimer(duration) {
        let timer = duration, minutes, seconds;
        const display = $('#timer');

        const interval = setInterval(function () {
            minutes = parseInt(timer / 60, 10);
            seconds = parseInt(timer % 60, 10);

            minutes = minutes < 10 ? "0" + minutes : minutes;
            seconds = seconds < 10 ? "0" + seconds : seconds;

            display.text(minutes + ":" + seconds);

            if (--timer < 0) {
                clearInterval(interval);
                display.text("Voting has ended.");
                $('#qrCodeSection').hide();
            }
        }, 1000);
    }
});
