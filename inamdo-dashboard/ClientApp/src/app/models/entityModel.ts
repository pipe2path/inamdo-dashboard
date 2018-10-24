export class entityModel {
  public entityId: string;
  public entityCategoryId: string;
  public entityName: string;
  public contactName: string;
  public address: string;
  public website: string;
  public phone: string;
  public email: string;

  constructor(entityId, entityCategoryId, entityName, contactName, address, website, phone, email) {
    this.entityId = entityId;
    this.entityCategoryId = entityCategoryId;
    this.entityName = entityName;
    this.contactName = contactName;
    this.address = address;
    this.website = website;
    this.phone = phone;
    this.email = email;
  }
}
