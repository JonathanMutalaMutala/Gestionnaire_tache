import { Component } from '@angular/core';
import { GestionnaireTaskServiceService } from './gestionnaire-task-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  constructor (private GestionnaireTaskServiceService: GestionnaireTaskServiceService) {

  }

  ngOnInit(): void {
    this.fetchData();
  }
  items = ['element 1', 'element 2', 'element 3']


  fetchData(): void {
    this.GestionnaireTaskServiceService.getColumnById(1).subscribe((response) => {
      console.log(response)
    })
  }


  title = 'Gestionnaire_UI';
}
