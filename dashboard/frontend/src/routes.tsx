import Dashboard from './pages/Dashboard'
import Network from './pages/Network'
import Jobs from './pages/Jobs'
import Job from './pages/Job'

export type IRouteObject = {
  id: string,
  title?: string,
  render: {
    (): JSX.Element,
  },
  params: Record<string, any>,
}

export type IRouteFactory = (props: Record<string, any>) => IRouteObject

export const routes: Record<string, IRouteFactory> = {
  '/': () => ({
    id: 'home',
    title: 'Home',
    render: () => <Dashboard />,
    params: {},
  }),
  '/network': () => ({
    id: 'network',
    title: 'Network',
    render: () => <Network />,
    params: {},
  }),
  '/jobs': () => ({
    id: 'jobs',
    title: 'Jobs',
    render: () => <Jobs />,
    params: {},
  }),
  '/jobs/:id': ({id}) => ({
    id: 'jobs.page',
    title: 'Job',
    render: () => <Job id={ id } />,
    params: {},
  }),
}

export default routes