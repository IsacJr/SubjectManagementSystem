export interface FilterQueryParamsModel {
    field?: number,
    status?: number,
    institution?: number,
    subject?: number,
    professor?: number,
    challenge?: number,
    userType?: number,
    page?: number
}

export interface FilterItem {
    visible: boolean,
    list: any[]
}