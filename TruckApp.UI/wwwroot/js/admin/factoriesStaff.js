var app = new Vue({
    el: '#app',
    data: {
        factories: [],
        selectedFactory: null,
        newFactoryStaff: {
            factoryid: 0,
            firstName: "FirstName",
            lastName: "LastName",
            Email: "mail@gmail.com",
            Phone1: "(305) 123 5555",
            Fax1: "(305) 321 8080",
            description: "Description"
        }

    },
    mounted() {
        this.getFactoryStaff();
    },
    methods: {
        getFactoryStaff() {
            this.loading = true;
            axios.get('/Admin/factoriesStaff/')
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
        updateFactoryStaff() {
            this.loading = true;
            axios.put('/Admin/factoriesStaff/', {
                factoryStaff: this.selectedFactory.factoryStaff.map(x => {
                    return {
                        id: x.id,
                        firstName: x.firstName,
                        lastName: x.lastName,
                        email: x.email,
                        phone1: x.phone1,
                        fax1: x.fax1,
                        description: x.description,
                        factoryId: this.selectedFactory.id
                    };
                })
            })
                .then(res => {
                    console.log(res);
                    this.selectedFactory.factoryStaff.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        deleteFactoryStaff(id, index) {
            this.loading = true;
            axios.delete('/Admin/factoriesStaff/' + id)
                .then(res => {
                    console.log(res);
                    this.selectedFactory.factoryStaff.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        addFactoryStaff() {
            this.loading = true;
            axios.post('/Admin/factoriesStaff/', this.newFactoryStaff)
                .then(res => {
                    console.log(res);
                    this.selectedFactory.factoryStaff.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        selectFactory(factory) {
            this.selectedFactory = factory;
            this.newFactoryStaff.factoryId = factory.id;
        }
    }

})