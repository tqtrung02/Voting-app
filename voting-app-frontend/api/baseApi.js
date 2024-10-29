// api.js
const axios = require('axios');

// Tạo một instance Axios
const api = axios.create({
    baseURL: 'https://localhost:7224/api', // Thay đổi baseURL theo ứng dụng của bạn
});

// Thêm interceptor cho các request
api.interceptors.request.use(config => {
    const token = localStorage.getItem('jwt-token'); // Lấy token từ local storage
    config.headers['Content-Type'] = 'application/json'
    if (token) {
        config.headers['Authorization'] = `Bearer ${token}`;
    }

    return config;
}, error => {
    return Promise.reject(error);
});

// Xuất instance để sử dụng trong ứng dụng
module.exports = api;
