import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { EntityService } from '../services/entity.service';
import { entityModel } from '../models/entityModel';

@Component({
  selector: 'app-entity-editor',
  templateUrl: './entity-editor.component.html',
  styleUrls: ['./entity-editor.component.css'],
  providers: [EntityService]
})
export class EntityEditorComponent implements OnInit {

  public entity: entityModel;
  form: FormGroup;
  constructor(private entityService: EntityService) {
    this.form = this.createFormGroup();
  }

  ngOnInit() {
    this.getEntityInfo();
  }

  populateForm() {
    if (this.entity != null) {
      this.form.patchValue({
        entityName: this.entity.entityName,
        contactName: this.entity.contactName,
        address: this.entity.address,
        website: this.entity.website,
        email: this.entity.email,
        phone: this.entity.phone
      })
    }
  }

  createFormGroup() {
    return new FormGroup({
      entityName: new FormControl(''),
      contactName: new FormControl(''),
      address: new FormControl(''),
      website: new FormControl(''),
      email: new FormControl(''),
      phone: new FormControl('')
    })
  }

  getEntityInfo(): void {
    this.entityService.getEntity('1').subscribe(
      data => {
        this.entity = data;
        this.populateForm();
      },
      err => console.error(err),
      () => console.log('done loading entity')
    );
    this.populateForm();
  }

  //getEntityInfo(): void {
  //  this.entityService.getEntity('1').toPromise().then(data => {
  //    this.entity = data;
  //    this.populateForm();
  //  })
  //}
 }
