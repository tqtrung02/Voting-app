const path = require('path');
const fs = require('fs');

const getAllJsFiles = (dir) => {
    let results = [];
    const list = fs.readdirSync(dir);

    list.forEach(file => {
        const filePath = path.join(dir, file);
        const stat = fs.statSync(filePath);

        // Nếu là thư mục, gọi đệ quy
        if (stat && stat.isDirectory()) {
            results = results.concat(getAllJsFiles(filePath)); // Thêm file từ thư mục con
        } else if (filePath.endsWith('.js')) {
            results.push(filePath); // Thêm file .js vào danh sách
        }
    });

    return results;
};

module.exports = {
    mode: 'development',
    entry: () => {
        const jsFiles = getAllJsFiles(path.join(__dirname, 'jsmodule')); // Lấy tất cả file .js
        console.log('JS files found:', jsFiles); // Xem danh sách các file

        // Trả về đối tượng chứa đường dẫn file và tên định dạng
        return jsFiles.reduce((entries, file) => {
            // Định dạng tên file theo yêu cầu
            const relativePath = path.relative(path.join(__dirname, 'jsmodule'), file); // Đường dẫn tương đối từ jsmodule
            const formattedName = relativePath.replace(/\\/g, '.').replace('.js', ''); // Thay thế '/' bằng '.' và xóa .js
            entries[formattedName] = file; // Thêm vào đối tượng entries
            return entries;
        }, {});
    },
    output: {
        path: path.resolve(__dirname, 'dist'), // Đường dẫn thư mục đầu ra
        filename: '[name].js', // Tên file đầu ra
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env'],
                    },
                },
            },
        ],
    },
};
