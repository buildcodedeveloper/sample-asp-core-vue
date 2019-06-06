// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const apiUrl = 'https://openwhisk.ng.bluemix.net/api/v1/web/rcamden%40us.ibm.com_My%20Space/safeToDelete/productName.json?name=';

const app = new Vue({
    el: '#app',
    data: {
        message: 'Cadastrar Participantes',
        errors: [],
        title: 'Allan Freitas grupo VueJS'
    },
    methods: {
        checkForm: function (e) {
            e.preventDefault();
            console.log("work");

            this.errors = [];
            if (this.name === '') {
                this.errors.push('Product name is required.');
            } else {
                console.log(this.form);
            }
        }
    }
})