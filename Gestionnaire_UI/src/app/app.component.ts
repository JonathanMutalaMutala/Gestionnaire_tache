import { Component } from '@angular/core';
import { GestionnaireTaskServiceService } from './gestionnaire-task-service.service';
import { ColumnDto } from './column-dto-model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  constructor (private GestionnaireTaskServiceService: GestionnaireTaskServiceService) {}

  columns: ColumnDto[] = []

  async ngOnInit() {
    try {
      this.columns = await this.GestionnaireTaskServiceService.getAllColumn()
      console.log(this.columns)
    } catch (error) {
      console.log(error)
    }
  }
  items = ['element 1', 'element 2', 'element 3']


  title = 'Gestionnaire_UI';
}
