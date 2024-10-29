const api = require('../api/baseApi.js');

async function  handleCredentialResponse(response) {
    const id_token = response.credential;
    const {data: token} = await api.post('/Auth/login', JSON.stringify(id_token))
    debugger;
    console.log(token);
    localStorage.setItem('jwt-token', token);
    await api.post('/Auth/heal')
}

window.onload = function () {
    google.accounts.id.initialize({
        client_id: '238437097590-tdl93rtt0kma8iav7nj8vk3a6njcldpg.apps.googleusercontent.com',
        callback: handleCredentialResponse
    });

    google.accounts.id.renderButton(
        document.getElementById("buttonDiv"),
        { theme: "outline" }  // Thay đổi tùy ý
    );

    google.accounts.id.prompt(); // Hiện hộp thoại đăng nhập nếu cần
};