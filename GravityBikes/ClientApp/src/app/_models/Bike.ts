export interface Bike {
    bikeId: number;
    bikePrice: number;
    bikeDateOfHireStart: Date;
    bikeDateOfHireStop: Date;
    bikeIsAvaible: boolean;
    bikeModel: string;
    bikeSize: BikeSizes;
    bikeGender: BikeGenders;
    bikeType: BikeTypes;
    photoUrl: string;


}
enum BikeSizes {
    s = 0,
    m = 1,
    l = 2,
    xl = 3
}

enum BikeGenders {
    male = 0,
    female = 1
}

export enum BikeTypes {
    downhill, freeride = 0,
    enduro = 1,
    forKids = 2
}
