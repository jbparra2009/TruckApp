﻿var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        truckModel: {
            id: 0,
            vin: "1FUJGLDR8DSBU5416",
            year: "2010",
            make: "FRHT",
            type: "Type",
            class: "Class",
            bodyType: "Body Type",
            lenght: "Lenght",
            description: "Description",

            truckPlate: "Truck Plate",
            truckNumber: "Truck Number",

            registrantName: "Registrant Name",
            titleState: "Title State",
            ownerLessorName: "Owner Lessor Name",
            expiresDate: "2010-01-31",
            efectiveDate: "2010-01-31",
            issueDate: "2010-01-31",
            purchasePrice: 10000.00,
            purchaseDate: "2010-01-31",

            status: "Active"
        },
        trucks: []
    },
    mounted() {
        this.getTrucks();
    },
    methods: {
        getTruck(id) {
            this.loading = true;
            axios.get('/Admin/trucks/' + id)
                .then(res => {
                    console.log(res);
                    var truck = res.data;
                    this.truckModel = {
                        id: truck.id,
                        vin: truck.vin,
                        year: truck.year,
                        make: truck.make,
                        type: truck.type,
                        class: truck.class,
                        bodyType: truck.bodyType,
                        lenght: truck.lenght,
                        description: truck.description,
                        truckPlate: truck.truckPlate,
                        truckNumber: truck.truckNumber,
                        registrantName: truck.registrantName,
                        titleState: truck.titleState,
                        ownerLessorName: truck.ownerLessorName,
                        expiresDate: truck.expiresDate,
                        efectiveDate: truck.efectiveDate,
                        issueDate: truck.issueDate,
                        purchasePrice: truck.purchasePrice,
                        purchaseDate: truck.purchaseDate,
                        status: truck.status,
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getTrucks() {
            this.loading = true;
            axios.get('/Admin/trucks')
                .then(res => {
                    console.log(res);
                    this.trucks = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createTruck() {
            this.loading = true;
            axios.post('/Admin/trucks', this.truckModel)
                .then(res => {
                    console.log(res.data);
                    this.trucks.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateTruck() {
            this.loading = true;
            axios.put('/Admin/trucks', this.truckModel)
                .then(res => {
                    console.log(res.data);
                    this.trucks.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        deleteTruck(id, index) {
            this.loading = true;
            axios.delete('/Admin/trucks/' + id)
                .then(res => {
                    console.log(res);
                    this.trucks.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newTruck() {
            this.editing = true;
            this.truckModel.id = 0;
        },
        editTruck(id, index) {
            this.objectIndex = index;
            this.getTruck(id);
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});