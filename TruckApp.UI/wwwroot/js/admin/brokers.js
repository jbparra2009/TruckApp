var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        brokerModel: {
            id: 0,
            brokerName: '',
            email: '',
            phone1: '',
            address1: '',
            city: '',
            state: '',
            zipCode: '',
            description: '',
            status: 'Active'
        },
        brokers: []
    },
    mounted() {
        this.getBrokers();
    },
    methods: {
        getBroker(id) {
            this.loading = true;
            axios.get('/Admin/brokers/' + id)
                .then(res => {
                    console.log(res);
                    var broker = res.data;
                    this.brokerModel = {
                        id: broker.id,
                        brokerName: broker.brokerName,
                        email: broker.email,
                        phone1: broker.phone1,
                        address1: broker.address1,
                        city: broker.city,
                        state: broker.state,
                        zipCode: broker.zipCode,

                        description: broker.description,

                        created: broker.created,
                        status: broker.status
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getBrokers() {
            this.loading = true;
            axios.get('/Admin/brokers/')
                .then(res => {
                    console.log(res);
                    this.brokers = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createBroker() {
            this.loading = true;
            axios.post('/Admin/brokers/', this.brokerModel)
                .then(res => {
                    console.log(res.data);
                    this.brokers.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        updateBroker() {
            this.loading = true;
            axios.put('/Admin/brokers', this.brokerModel)
                .then(res => {
                    console.log(res.data);
                    this.brokers.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        deleteBroker(id, index) {
            this.loading = true;
            axios.delete('/Admin/brokers/' + id)
                .then(res => {
                    console.log(res);
                    this.brokers.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newBroker() {
            this.editing = true;
            this.brokerModel.id = 0;
        },
        editBroker(id, index) {
            this.objectIndex = index;
            this.getBroker(id);
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});