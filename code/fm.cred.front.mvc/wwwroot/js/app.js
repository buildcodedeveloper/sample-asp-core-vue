// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const apiUrl = 'https://openwhisk.ng.bluemix.net/api/v1/web/rcamden%40us.ibm.com_My%20Space/safeToDelete/productName.json?name=';
// const config = {
//     aria: true,
//     classNames: {},
//     classes: false,
//     delay: 0,
//     dictionary: null,
//     errorBagName: 'errors', // change if property conflicts
//     events: 'input|blur',
//     fieldsBagName: 'fields',
//     i18n: null, // the vue-i18n plugin instance
//     i18nRootKey: 'validations', // the nested key under which the validation messages will be located
//     inject: true,
//     locale: 'en',
//     validity: true,
//     useConstraintAttrs: true
//   };




Vue.use(VeeValidate, VueResource)





Vue.component('form-generator', {
    props: ["schema", "value", "checkForm"],
    template: `
     <div class="form-row">
     
  <li v-for="error in errors.all()">{{ error }}</li>
</ul>
     <component
                v-for="(field, index) in schema"
                :key="index"
                :is="field.fieldType"
                :value="formData[field.value]"
                @input="updateForm(field.name, $event)"
                v-model="formData[field.name]"
                v-bind="field"
   ></component>


  </div>
 `,
    data() {
        return {
            formData: this.value || {}
        };
    },
    methods: {
        updateForm(fieldName, value) {
            this.$set(this.formData, fieldName, value);
            this.$emit("input", this.formData);
        },

    },
    inject: ['$validator'],

});

Vue.component('NumberInput', {
    name: 'NumberInput',
    props: ['placeholder', 'label', 'name', 'value', 'validate'],
    template: `
    <div>
    <label>{{label}}</label>
    <input type="number"
           :name="name"
           :value="value"
           :v-validate="validate"
           @input="$emit('input',
           $event.target.value)"
           :placeholder="placeholder">
  </div>
    `,
    inject: ['$validator'],
});

Vue.component('TextInput', {
    name: 'TextInput',
    props: ['placeholder', 'label', 'name', 'value', 'classCss', 'validate', 'default'],
    template: `
    <div :class="'form-group '+classCss">
    <label>{{label}}</label>

    <input   v-validate="validate" type="text"
           :name="name"
           class="form-control"
           :value="value"
           @input="$emit('input',$event.target.value)"
           
           :placeholder="placeholder"
           >

           <span>{{ errors.first(':name="name"') }}</span>

  </div>
    `,
    inject: ['$validator'],
    mounted() {
        if (this.default) {
            console.log(this.default);
            this.updateForm(this.fieldName, this.default);
        }
    },
    methods: {
        updateForm(fieldName, value) {
            this.$emit("input", value);
        },

    }

});
// var link = 'http://localhost:3000/configuracaoCampos';

// Vue.http.get(link).then(function(response){
//     data.list = response.data;
// }, function(error){
//     console.log(error.statusText);
// });

Vue.component('input-validate', {
    name: 'input-validate',
    props: ['placeholder', 'label', 'name', 'value', 'classCss', 'validate'],
    template: `
    <div >
    <label>{{label}}</label>

    <input   v-validate="'required|alpha'" type="text"
           name="cdParticipante"
           class="form-control col-md-4"

           >

  </div>
    `,
    inject: ['$validator'],

});

Vue.component('SelectList', {
    name: 'SelectList',
    props: ['multi', 'options', 'name', 'label', 'value', 'validate'],
    template: `
   <div>
    <label>{{label}}</label>
    <select :multiple="multi"
            :value="value"
            :name="name"
            class="custom-select"
            :v-validate="validate"
            @input="$emit('input',
           $event.target.value)">
      <option v-for="option in options"
              :key="option" :value="option">
        {{option}}
      </option>
    </select>
  </div>
  `
});

Vue.component('blog-post', {
    props: ['title', 'user'],
    template: `
 <input   v-validate="'required|alpha'" type="text"
           name="user.nome"
           v-model="user.nome"
           class="form-control col-md-4"

           >
    `

})
const ENDPOINT = 'https://api.github.com/orgs/codecasts/repos';
const app = new Vue({
    components: {},
    props: ["schema", "value"],
    el: '#app',
    inject: ['$validator'],
    data: {

        formData: this.value || {},
        schema: [],
        listField: [],
        repos: [],
    },
    methods: {


        getJsonConfig() {



            return this.listConfig;
        },
        checkForm: function (e) {
            e.preventDefault();


            this.$validator.validateAll().then((result) => {
                if (result) {
                    // eslint-disable-next-line
                    console.log(JSON.stringify(this.formData));
                    console.log('Form Submitted!');
                    return;
                }

                console.log('Correct them errors!');
            });

        },


    },
    // beforeMount() {
    //     this.$http.get(ENDPOINT)
    //     .then(response => response.data)
    //     .then(data => Vue.set(this, 'repos', data));
    //     console.log(this.repos)

    // },
    mounted() {
        // console.log(this.repos)
        this.$nextTick(function () {
            this.$http.get('http://localhost:3000/configuracaoCampos')
                .then(response => response.json())
                .then(json => {
                    // .then((response) => {     

                    this.listField = [];


                    if (json) {
                        json.forEach(e => {
                            var fieldType = {};


                            switch (e.tipoCampo.tipocampohtml.toLowerCase()) {
                                case 'SELECT'.toLowerCase():
                                    fieldType = MountedSelectList(e, this);
                                    break;

                                case 'TEXT'.toLowerCase():
                                    fieldType = MountedTextInput(e);
                                    break;

                                default:
                                    break;
                            }



                            this.listField.push(fieldType);
                        });
                    }



                    this.schema = this.listField;
                }, (error) => {
                    consoel.log(error)
                });
            // Código que irá rodar apenas após toda
            // a árvore do componente ter sido renderizada
            // const dict = {
            //     custom: {
            //         noParticipante: {
            //             alpha_num: 'Your email is empty'
            //       },
            //       name: {
            //         required: () => 'Your name is empty'
            //       }
            //     }
            //   };
              this.$validator.localize('pt');
            console.log("wor")
        })
    },
    computed() {
        console.log(this.repos())
    }
})

function PopulateData() {
    // $.getJSON( "ajax/test.json", function( data ) {
    //     var items = [];
    //     $.each( data, function( key, val ) {
    //       items.push( "<li id='" + key + "'>" + val + "</li>" );
    //     });

    //     $( "<ul/>", {
    //       "class": "my-new-list",
    //       html: items.join( "" )
    //     }).appendTo( "body" );
    //   });




    // return [{
    //         fieldType: 'SelectList',
    //         name: "options",
    //         data: ["", "Mr", "Ms", "Mx", "Dr", "Madam", "Lord", "GOT"]
    //     },
    //     {
    //         fieldType: 'TextInput',
    //         placeholder: "Last Name",
    //         label: "Last Name",
    //         name: "cdParticipante",
    //         default: "Participante 1",
    //         classCss: 'form-control col-md-6',
    //     }
    // ]


}

function MountedSelectList(e, $vue) {


    const selectOptions = {

        fieldType: "SelectList",
        name: e.dsdetalhescampo.nomeCampo,
        multi: false,
        label: e.noCampo,
        validate: "",
        options: e.dsdetalhescampo.listavaores
    }

    GetValidations(e, selectOptions)
    return selectOptions;
}

function MountedTextInput(e) {

    const inputText = {
        fieldType: "TextInput",
        placeholder: e.noCampo,
        label: e.noCampo,
        default: e.default,
        name: e.dsdetalhescampo.nomeCampo,
        classCss: e.classcss,
    }
    inputText.validate = GetValidations(e, inputText)
    return inputText;
}

function GetValidations($e, $input) {
    // var validationsSettings = null;
    let validationsSettings = {};


    if ($e.dsdetalhescampo.obrigatorio) {
        validationsSettings.required = true;

    }
    //     validationsSettings.required = true;

    if ($e.minText)
        validationsSettings += `|min=${$e.minText}`

    if ($e.maxText)
        validationsSettings += `|max=${$e.maxText}`


    if ($e.dsdetalhescampo.obrigatorio)
        validationsSettings = SetRequiredType($e, $input, validationsSettings)


    if ($e.dsdetalhescampo.maiuscMinusc.toLowerCase() === 'Upper'.toLowerCase())
        $input.label = $input.label.toUpperCase();

    if ($e.dsdetalhescampo.maiuscMinusc.toLowerCase() === 'Lower'.toLowerCase())
        $input.name = $input.name.toLowerCase();

    if ($e.dsdetalhescampo.obrigatorio)
        console.log(validationsSettings)

    return validationsSettings
}

function SetRequiredType($e, $input, $validationsSettings) {

    switch ($e.tipoCampo.tipocampohtml.toLowerCase()) {
        case 'DATE'.toLowerCase():
            return $validationsSettings += '|date_format:dd/MM/yyyy'
            break;

        case 'EMAIL'.toLowerCase():
            return $validationsSettings.email = true;
            break;

        case 'CEP'.toLowerCase():
            return $validationsSettings.digits = 9;
            break;

        case 'CARD'.toLowerCase():
            return $validationsSettings.credit_card = true;
            break;

        case 'TEXT_NUM'.toLowerCase():
            return $validationsSettings.alpha_num = true;
            break;

        default:
            $validationsSettings.alpha_num = true;
            return $validationsSettings;
            break;
    }


}