export interface Tickets {
    liftTicketID: number;
    liftTicketUseCount: number;
    liftTicketDaysCount: number;
    liftTicketPriceReduced: number;
    isDayLimitedTicket: boolean;
    liftTicketPrice: number;
    liftTicketType: string;
    limitStart: Date;
    limitStop: Date;
}
