
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
// Vue.prototype.$axios = axios

Vue.use(VeeValidate )





Vue.component('form-generator', {
    props: ["schema", "value"],
    template: `
     <div>
    <component v-for="(field, index) in schema"
               :key="index"
               :is="field.fieldType"
               :value="formData[field.name]"
               @input="updateForm(field.name, $event)"
               v-bind="field">
    </component>
  </div>
 `,inject: ['$validator'],
    data() {
        return {
            formData: this.value || {}
        };
    },
    methods: {
        updateForm(fieldName, value) {
            this.$set(this.formData, fieldName, value);
            this.$emit("input", this.formData);
        }
    }

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
});

Vue.component('TextInput', {
    name: 'TextInput',
    props: ['placeholder', 'label', 'name', 'value', 'classCss', 'validate'],
    template: `
    <div>
    <label>{{label}}</label>

    <input   v-validate="validate" type="text"
           :name="name"
           :class="classCss"
           :value="value"
           @input="$emit('input',$event.target.value)"
           :placeholder="placeholder"
           >

  </div>
    `,
     inject: ['$validator'],
});

Vue.component('input-validate', {
    name: 'input-validate',
    props: ['placeholder', 'label', 'name', 'value', 'classCss', 'validate'],
    template: `
    <div>
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
            :v-validate="validate"
            @input="$emit('input',
           $event.target.value)">
      <option v-for="option in options"
              :key="option">
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

const app = new Vue({
    components: {},
    el: '#app',
    data: {
        user: {
            nome: 'teste',
        },
        formData: {},
        schema: []
        // {
        //   fieldType: "TextInput",
        //   placeholder: "First Name",
        //   label: "First Name",
        //   name: "firstName",
        //   classCss: 'form-control col-md-6',
        // },
        // {
        //   fieldType: "TextInput",
        //   placeholder: "Last Name",
        //   label: "Last Name",
        //   name: "lastName",
        //   classCss: 'form-control col-md-6',
        // },
        // {
        //   fieldType: "NumberInput",
        //   placeholder: "Age",
        //   name: "age",
        //   label: "Age",
        //   minValue: 0
        // }


    },
    methods: {
        checkForm: function (e) {
            e.preventDefault();


           this.$validator.validateAll().then((result) => {
                if (result) {
                  // eslint-disable-next-line
                  console.log(this.formData);
                  console.log('Form Submitted!');
                  return;
                }

                console.log('Correct them errors!');
              });


            // this.errors = [];
            // if (this.name === '') {
            //     this.errors.push('Product name is required.');
            // } else {
            //     console.log(this.form);
            // }
        }
    },

    created: function () {
        // this.$nextTick(function () {
            // Código que irá rodar apenas após toda
            // a árvore do componente ter sido renderizada
            var listField = [];
            var data = PopulateData();

            data.forEach(e => {
                var fieldType = {};

                console.log(e.fieldType)
                switch (e.fieldType.toLowerCase()) {
                    case 'SelectList'.toLowerCase():
                        fieldType = MountedSelectList(e, this);
                        break;

                    case 'TextInput'.toLowerCase():
                        fieldType = MountedTextInput(e);
                        break;

                    default:
                        break;
                }



                listField.push(fieldType);
            });


            this.schema = listField;
        // })
    },
    mounted () {

      }
})

function PopulateData() {
    return [{
            fieldType: 'SelectList',
            name: "options",
            data: ["", "Mr", "Ms", "Mx", "Dr", "Madam", "Lord", "GOT"]
        },
        {
            fieldType: 'TextInput',
            placeholder: "Last Name",
            label: "Last Name",
            name: "cdParticipante",
            classCss: 'form-control col-md-6',
        }
    ]


}
function MountedSelectList(e, $vue) {



        return {

            fieldType: "SelectList",
            name: "title",
            multi: false,
            label: "Title",
            validate: "required|min:6",
            options: e.data
        }
}

function MountedTextInput(e) {
    return {

        fieldType: "TextInput",
        placeholder: "First Name",
        label: "First Name",
        validate: "required|min:6",
        name: e.name,
        classCss: e.classCss,
    }
}