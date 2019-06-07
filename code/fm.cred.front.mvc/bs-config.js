let proxy = require('http-proxy-middleware');
let fallback = require('connect-history-api-fallback');
module.exports = {
    files: ['./wwwroot/**/*.css', './wwwroot/**/*.js', , './wwwroot/**/*.scss', './wwwroot/**/*.sass', './Views/**/*.cshtml'],
    browser: "chrome",
    injectChanges : true,
    server: {
        middleware: {
            1: proxy('/', {target: 'http://localhost:5000', changeOrigin: false }),           
           
        }
    },
};