var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        factoryModel: {
            id: 0,
            name: "Name",
            email: "Email",
            phone1: "Phone",
            address1: "Address",
            city: "City",
            state: "State",
            zipCode: "ZipCode",
            description: "Description",
            rate: 1.00,
            status: "Active"
        },
        factories: []
    },
    mounted() {
        this.getFactories();
    },
    methods: {
        getFactory(id) {
            this.loading = true;
            axios.get('/Admin/factories/' + id)
                .then(res => {
                    console.log(res);
                    var factory = res.data;
                    this.factoryModel = {
                        id: factory.id,
                        name: factory.name,
                        email: factory.email,
                        phone1: factory.phone1,
                        address1: factory.address1,
                        city: factory.city,
                        state: factory.state,
                        zipCode: factory.zipCode,
                        description: factory.description,
                        rate: factory.rate,
                        status: factory.status
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getFactories() {
            this.loading = true;
            axios.get('/Admin/factories')
                .then(res => {
                    console.log(res);
                    this.factories = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createFactory() {
            this.loading = true;
            axios.post('/Admin/factories', this.factoryModel)
                .then(res => {
                    console.log(res.data);
                    this.factories.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateFactory() {
            this.loading = true;
            axios.put('/Admin/factories', this.factoryModel)
                .then(res => {
                    console.log(res.data);
                    this.factories.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        deleteFactory(id, index) {
            this.loading = true;
            axios.delete('/Admin/factories/' + id)
                .then(res => {
                    console.log(res);
                    this.factories.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newFactory() {
            this.editing = true;
            this.factoryModel.id = 0;
        },
        editFactory(id, index) {
            this.objectIndex = index;
            this.getFactory(id);
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});