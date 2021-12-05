export interface FilterQueryParamsModel {
    field?: number,
    status?: number,
    institution?: number,
    subject?: number,
    professor?: number,
    userType?: number
}

export interface FilterItem {
    visible: boolean,
    list: any[]
}