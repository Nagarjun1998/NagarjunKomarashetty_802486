export class Payment {
    public  paymentId : string
        public  amount : number
       
        public  userId : string
        
        public  mentorId : string
        
        public trainingId : string
        public  amountToMentor :number;

        constructor(){
            this.paymentId="P" + Math.round((Math.random()*9000));

        }
}

