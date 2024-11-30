export interface ColumnDto {
  name: string;
  description?: string
  order: number
  taches: Tache[]
}

export interface Tache {
  title: string
  description?: string
  isCompleted: boolean
  createdAt: Date
  ColumnId: number
}
