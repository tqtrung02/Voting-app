const path = require('path');
const glob = require('glob');

module.exports = {
    entry: {
        login: './jsmodule/login.js'
    }, 
    output: {
        filename: '[name].js', // Tên file đầu ra
        path: path.resolve(__dirname, 'dist'), // Thư mục output,
        clean: true, // Xóa thư mục dist trước khi build
    },
    mode: 'development', // Chế độ development,
};
