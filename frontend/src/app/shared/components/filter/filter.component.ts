import { Component, Input, OnInit } from '@angular/core';
import { FilterItem } from '../../models/filterQueryParamsModel';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.scss']
})
export class FilterComponent implements OnInit {

  @Input()
  public fieldInput = { } as FilterItem;
  @Input()
  public statusInput = { } as FilterItem;
  @Input()
  public institutionInput = { } as FilterItem;
  @Input()
  public subjectInput = { } as FilterItem;
  @Input()
  public professorInput = { } as FilterItem;
  @Input()
  public userTypeInput = { } as FilterItem;
  
  constructor() { }

  ngOnInit(): void {
  }

}
