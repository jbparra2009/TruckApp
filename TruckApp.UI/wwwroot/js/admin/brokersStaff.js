var app = new Vue({
    el: '#app',
    data: {
        brokers: [],
        selectedBroker: null,
        newBrokerStaff: {
            brokerId: 0,
            firstName: "FirstName",
            lastName: "LastName",
            email: "mail@gmail.com",
            phone1: "(305) 123 5555",
            fax1: "(305) 321 8080",
            description: "Description"
        }

    },
    mounted() {
        this.getBrokerStaff();
    },
    methods: {
        getBrokerStaff() {
            this.loading = true;
            axios.get('/Admin/brokersStaff/')
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
        updateBrokerStaff() {
            this.loading = true;
            axios.put('/Admin/brokersStaff/', {
                brokerStaff: this.selectedBroker.brokerStaff.map(x => {
                    return {
                        id: x.id,
                        firstName: x.firstName,
                        lastName: x.lastName,
                        email: x.email,
                        phone1: x.phone1,
                        fax1: x.fax1,
                        description: x.description,
                        brokerId: this.selectedBroker.id
                    };
                })  
            })
                .then(res => {
                    console.log(res);
                    this.selectedBroker.brokerStaff.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        deleteBrokerStaff(id, index) {
            this.loading = true;
            axios.delete('/Admin/brokersStaff/' + id)
                .then(res => {
                    console.log(res);
                    this.selectedBroker.brokerStaff.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        addBrokerStaff() {
            this.loading = true;
            axios.post('/Admin/brokersStaff/', this.newBrokerStaff)
                .then(res => {
                    console.log(res);
                    this.selectedBroker.brokerStaff.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        selectBroker(broker) {
            this.selectedBroker = broker;
            this.newBrokerStaff.brokerId = broker.id;
        }
    }

})