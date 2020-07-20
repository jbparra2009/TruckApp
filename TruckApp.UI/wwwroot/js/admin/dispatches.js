var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        dispatchModel: {
            id: 0,
            firstName: 'FirstName',
            lastName: 'LastName',
            email: 'Email',
            phone1: 'Phone',
            address1: 'Address',
            city: 'City',
            state: 'State',
            zipCode: 'ZipCode',
            description: 'Description',
            ss: 'SS',
            corpName: 'CorpName',
            ein: 'EIN',
            rate: 1.00,
            status: 'Active'
        },
        dispatches: []
    },
    mounted() {
        this.getDispatches();
    },
    methods: {
        getDispatch(id) {
            this.loading = true;
            axios.get('/Admin/dispatches/' + id)
                .then(res => {
                    console.log(res);
                    var dispatch = res.data;
                    this.dispatchModel = {
                        id: dispatch.id,
                        firstName: dispatch.firstName,
                        lastName: dispatch.lastName,
                        email: dispatch.email,
                        phone1: dispatch.phone1,
                        address1: dispatch.address1,
                        city: dispatch.city,
                        state: dispatch.state,
                        zipCode: dispatch.zipCode,
                        description: dispatch.description,
                        ss: dispatch.ss,
                        corpName: dispatch.corpName,
                        ein: dispatch.ein,
                        rate: dispatch.rate,
                        created: dispatch.created,
                        status: dispatch.status,
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getDispatches() {
            this.loading = true;
            axios.get('/Admin/dispatches')
                .then(res => {
                    console.log(res);
                    this.dispatches = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createDispatch() {
            this.loading = true;
            axios.post('/Admin/dispatches', this.dispatchModel)
                .then(res => {
                    console.log(res.data);
                    this.dispatches.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        updateDispatch() {
            this.loading = true;
            axios.put('/Admin/dispatches', this.dispatchModel)
                .then(res => {
                    console.log(res.data);
                    this.dispatches.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        deleteDispatch(id, index) {
            this.loading = true;
            axios.delete('/Admin/dispatches/' + id)
                .then(res => {
                    console.log(res);
                    this.dispatches.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newDispatch() {
            this.editing = true;
            this.dispatchModel.id = 0;
        },
        editDispatch(id, index) {
            this.objectIndex = index;
            this.getDispatch(id);
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});