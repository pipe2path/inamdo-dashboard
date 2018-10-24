import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { EntityService } from '../services/entity.service';

@Component({
  selector: 'app-entity-editor',
  templateUrl: './entity-editor.component.html',
  styleUrls: ['./entity-editor.component.css'],
  providers: [EntityService]
})
export class EntityEditorComponent implements OnInit {

  public entity;
  entityForm: FormGroup;
  constructor(private entityService: EntityService) {
    this.entityForm = this.createFormGroup();
  }

  ngOnInit() {
    this.getEntityInfo();
  }

  createFormGroup() {
    return new FormGroup({
        name: new FormControl(''),
        contact: new FormControl(''),
        address: new FormControl(''),
        email: new FormControl(''),
        phone: new FormControl('')
      })   
  }
  getEntityInfo() {
    var entity = this.entityService.getEntity('1').subscribe(
      data => { this.entity = data },
    err => console.error(err),
      () => console.log('done loading entity')
    );
  }
}
